CREATE TABLE IF NOT EXISTS inventory 
(
    sku INT PRIMARY KEY,
    amount INT 
);

INSERT INTO inventory (amount, sku) VALUES (1, 200) ON CONFLICT (sku) DO NOTHING;

