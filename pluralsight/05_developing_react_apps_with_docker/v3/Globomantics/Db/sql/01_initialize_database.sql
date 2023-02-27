CREATE TABLE IF NOT EXISTS inventory 
(
    sku INT PRIMARY KEY,
    amount INT 
);

INSERT INTO inventory (amount, sku)
SELECT 
    1 AS sku,
    100 AS amount
WHERE
    NOT EXISTS (SELECT 1 FROM inventory WHERE sku = 1);


