SELECT p.Title AS Product, c.Title AS Category FROM Product as p LEFT JOIN
Product_Category AS pc ON p.Id = pc.Product LEFT JOIN
Category AS c ON pc.Category = c.Id;