import { Pool } from 'pg';

export interface DbOptions {
  host: string;
  port: number;
  database: string;
  user: string;
  password: string;
}

class Db {
  private _pool: Pool;

  constructor(options: DbOptions) {
    this._pool = new Pool({
      host: options.host,
      port: options.port,
      database: options.database,
      user: options.user,
      password: options.password,
    });
  }

  public async connect(): Promise<void> {
    await this._pool.connect();
  }

  public async query(query: string, values?: any[]): Promise<any> {
    const result = await this._pool.query(query, values);

    return result.rows;
  }

  public async disconnect(): Promise<void> {
    await this._pool.end();
  }
}

export default Db;
