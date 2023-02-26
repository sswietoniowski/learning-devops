import express, { Express, Request, Response } from 'express';

const app: Express = express();
const port: number = 3001;

app.get('/', (_: Request, res: Response) => {
  res.status(200).send('Hello World!');
});

app.listen(port, () => {
  console.log(`Server is listening on port ${port}`);
});
