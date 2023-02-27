import { RedisClientType } from '@redis/client';
import { createClient } from 'redis';

export interface CacheOptions {
  host: string;
  port: number;
}

class Cache {
  private _client: RedisClientType;

  constructor(options: CacheOptions) {
    this._client = createClient({
      url: `redis://${options.host}:${options.port}`,
    } as any);
  }

  public async connect(): Promise<void> {
    console.log('[CACHE] connect');
    await this._client.connect();
  }

  public async set(key: string, value: any): Promise<void> {
    await this._client.set(key, value);
  }

  public async get(key: string): Promise<any | null> {
    return await this._client.get(key);
  }

  public async disconnect(): Promise<void> {
    console.log('[CACHE] disconnect');
    await this._client.disconnect();
  }
}

export default Cache;
