import currency from 'currency.js';
import Cache, { CacheOptions } from './Cache';
import Db, { DbOptions } from './Db';

class InventoryService {
  private readonly _INVENTORY_COUNT_KEY: string = 'inventory_count';
  private readonly _INVENTORY_SKU: number = 1;

  private _cache: Cache;
  private _db: Db;

  constructor(dbOptions: DbOptions, cacheOptions: CacheOptions) {
    this._cache = new Cache(cacheOptions);
    this._db = new Db(dbOptions);
  }

  public async connect(): Promise<void> {
    console.log('[SERVICE] connect');
    await this._cache.connect();
    await this._db.connect();
  }

  public async incrementAndGetInventoryCount(): Promise<number> {
    let count = await this.getCount();
    count++;
    await this.setCount(count);
    console.log(`[SERVICE] increment and get inventory count: ${count}`);
    return count;
  }

  private async setCount(count: number): Promise<void> {
    await this._cache.set(this._INVENTORY_COUNT_KEY, count.toString());
    console.log(`[CACHE] set count: ${count}`);
  }

  private async getCount(): Promise<number> {
    let countValue = (await this._cache.get(this._INVENTORY_COUNT_KEY)) || '0';
    let count = parseInt(countValue);
    console.log(`[CACHE] get count: ${count}`);
    return count;
  }

  private async getPrice(): Promise<number> {
    const result = await this._db.query(
      'SELECT price FROM inventory WHERE sku = $1',
      [this._INVENTORY_SKU]
    );
    const price = currency(result.rows[0].price);
    console.log(`[DB] get price: ${price}`);
    return price.value;
  }

  public async getInventoryAmount(): Promise<number> {
    const price = await this.getPrice();
    const count = await this.getCount();
    const amount = price * count;
    console.log(`[SERVICE] get amount: ${amount}`);
    return amount;
  }

  public async disconnect(): Promise<void> {
    console.log('[SERVICE] disconnect');
    await this._cache.disconnect();
    await this._db.disconnect();
  }
}

export default InventoryService;
