import express, { Express, Request, Response } from 'express';
import cors from 'cors';
import bodyParser from 'body-parser';
import { CacheOptions } from './cache';
import { DbOptions } from './db';
import InventoryService from './InventoryService';

// All options can be read from environment variables

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

app.use(cors({ origin: ['http://localhost:3000', 'http://client:3000'] }));
// app.use(cors());

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));

app.get('/api/inventory/count', async (_: Request, res: Response) => {
  try {
    const count = await inventoryService.incrementAndGetInventoryCount();

    res.status(200).json(count);
  } catch (err) {
    console.log(err);
    res.status(500).send('Error...');
  }
});

app.get('/api/inventory/amount', async (_: Request, res: Response) => {
  try {
    const amount = await inventoryService.getInventoryAmount();

    res.status(200).json(amount);
  } catch (err) {
    console.log(err);
    res.status(500).send('Error...');
  }
});

// @ts-ignore
if (import.meta.env.PROD) {
  const port: number = 3001;

  app.listen(port, () => {
    console.log(`Server is listening on port ${port}`);
  });
}

export const viteNodeApp = app;
