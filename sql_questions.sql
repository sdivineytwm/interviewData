-- 1. Show list of all ProductCategoryNames and the total number of products contained with in each category.
-- Follow up: Show the average UnitCost for each ProductCategoryName/ProductSubcategoryName combination.
--Select ProductCategoryNames, Count(*) from DimProduct group by ProductCategoryKey


-- 2. Show list of all Store Names along with the total number of machines associated with each store. Exclude stores which are closed.
-- Follow up: Use a window function instead of group by to find the same result (or use group by if window function was used already).
Select b.StoreName, count(a.MachineKey) FROM [ContosoRetailDW].[dbo].[DimMachine] as a join [ContosoRetailDW].[dbo].[DimStore] as b on a.StoreKey = b.StoreKey group by b.storeName


-- 3. How many sales from FactSales have promotions (DimPromotions) which ended before or started after the date of the sale? Exclude sales with the “No Discount” promotion from this count.
Select Count(*) from FactSales as a join DimPromotion as b on a.PromotionKey = b.PromotionKey where b.EndDate < a.DateKey or b.StartDate > a.DateKey 


-- 4. Show a list of all customers whose birthday is today.
Select * from DimCustomer where BirthDate = SYSDATETIME() 


-- 5. Which employee of the employees no longer with the company (has EndDate in DimEmployee) had the longest duration of employment (in days)?
Select MAX(EndDate - StartDate) from DimEmployee where EndDate is not null


-- ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- 1. Show all possible names of creatures ordered alphabetically.
-- 2. Show stats for any creature which has the max amount of Health (stats are in creature_template)?
-- 3. Show the individual spawn data and any movement data for creature with Guid #24429.
-- 4. What is the Entry of the creature named “Stone Guardian”? How many creatures with name "Stone Guardian" are spawned in the game world?
-- 5. How many movement points do all the Stone Guardian spawns have combined?
-- 6. Show a list of total creature spawn counts for each Name/Entry.
-- 7. Show the Name from all creature templates along with the total number movement points of all creature spawns associated with each template/Name.
-- 8. Change WaitTime to 5000 for every movement point it's currently 0 for every creature Stone Guardian spawn.
-- 9. Delete all movement for all Stone Guardians.

-- Imagine you were tasked with creating a new system for the game which allows every individual creature spawn in the creature table to have many possible Entries/Creature Templates.
-- Any idea how you would change the current DB schema to support this?


