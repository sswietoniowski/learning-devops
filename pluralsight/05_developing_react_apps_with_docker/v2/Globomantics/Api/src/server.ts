import express, { Express, Request, Response } from 'express';
import { createClient } from 'redis';

const app: Express = express();
const port: number = 3001;

const client = createClient({
  host: 'redis',
  port: 6379,
} as any);

const REDIS_INVENTORY_KEY = 'inventory_count';

try {
  await client.connect();
  await client.set(REDIS_INVENTORY_KEY, 0);
} catch (err) {
  console.log(err);
}

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
