import express, { Express, Request, Response } from 'express';
import cors from 'cors';
import bodyParser from 'body-parser';
import { CacheOptions } from './cache';
import { DbOptions } from './db';
import InventoryService from './InventoryService';

const cacheOptions: CacheOptions = {
  host: 'redis',
  port: 6379,
};

const dbOptions: DbOptions = {
  host: 'postgres',
  port: 5432,
  database: 'globomantics',
  user: 'postgres',
  password: 'postgres',
};

const inventoryService = new InventoryService(dbOptions, cacheOptions);

try {
  await inventoryService.connect();
} catch (err) {
  console.log(err);
}

const app: Express = express();
const port: number = 3001;

app.use(cors({ origin: ['http://localhost:3000', 'http://client:3000'] }));
// app.use(cors());

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));
app.get('/api/inventory', async (_: Request, res: Response) => {
  try {
    const count = await inventoryService.getIncrementedInventoryCount();
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
