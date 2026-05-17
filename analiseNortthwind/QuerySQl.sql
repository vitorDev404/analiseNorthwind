USE Northwind;
GO
SELECT
    p.ProductID AS ID,
    p.ProductName AS Produto,
    SUM(od.Quantity) AS QuantidadeVendida
FROM Products p
JOIN [Order Details] od
    ON p.ProductID = od.ProductID
WHERE p.ProductID BETWEEN 1 AND 77
GROUP BY
    p.ProductID,
    p.ProductName
ORDER BY ID ASC;
GO