
SELECT * FROM sallary
WHERE countofsall BETWEEN 100 AND 6000
AND NOT classofemployee IN ('Loyer','client','provider');