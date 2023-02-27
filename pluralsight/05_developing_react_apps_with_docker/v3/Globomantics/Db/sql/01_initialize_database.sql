CREATE TABLE IF NOT EXISTS inventory 
(
    sku INT NOT NULL PRIMARY KEY,
    price MONEY NOT NULL
);

INSERT INTO inventory (amount, sku) VALUES (1, 3.99) ON CONFLICT (sku) DO NOTHING;
