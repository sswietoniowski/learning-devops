import express, { Express, Request, Response } from 'express';
import { createClient } from 'redis';
import cors from 'cors';

const app: Express = express();
const port: number = 3001;

const client = createClient({
  url: 'redis://redis', // to work inside container: https://stackoverflow.com/questions/71717395/getting-error-connect-econnrefused-127-0-0-16379-in-docker-compose-while-conne
  port: 6379,
} as any);

const REDIS_INVENTORY_KEY = 'inventory_count';

try {
  await client.connect();
  await client.set(REDIS_INVENTORY_KEY, 0);
} catch (err) {
  console.log(err);
}

app.use(cors({ origin: ['http://localhost:3000', 'http://client:3000'] }));
// app.use(cors());

app.get('/api/inventory', async (_: Request, res: Response) => {
  try {
    let value = (await client.get(REDIS_INVENTORY_KEY)) ?? '0';
    let count = parseInt(value) + 1;
    console.log(`Inventory count: ${count}`);
    await client.set(REDIS_INVENTORY_KEY, count);
    res.json(count);
    res.status(200);
  } catch (err) {
    console.log(err);
    res.status(500).send('Error...');
  }
});

// @ts-ignore
if (import.meta.env.PROD) {
  app.listen(port, () => {
    console.log(`Server is listening on port ${port}`);
  });
}

export const viteNodeApp = app;
