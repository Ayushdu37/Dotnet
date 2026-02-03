alter procedure GetAccountTransactionSummary(
	@StartDate date,
	@EndDate date,
	@AccountID int
)
as begin
	select
		sum(Amount) as TotalDeposited
	from Transactions
	where AccountID = @AccountID
		and TransactionType = 'Deposit'
		and TransactionDate between @StartDate and @EndDate;

	select
		sum(Amount) as TotalWithdrawn
	from Transactions
	where AccountID = @AccountID
		and TransactionType = 'Withdraw'
		and TransactionDate between @StartDate and @EndDate;
end;

EXEC GetAccountTransactionSummary 
     '2024-01-01', 
     '2024-01-31', 
     101;


------------------------------------------------------------------------------------

Insert into Bonus(AccountID,BonusMonth,BonusYear,BonusAmount,CreatedDate)
select 
    t.AccountID as AccountID,
    Month(t.TransactionDate) as BonusMonth,
    Year(t.TransactionDate) as BonusYear,
    1000 as BonusAmount,
    GETDATE() as CreatedDate
from Transactions t
where t.TransactionType='Deposit'
Group By YEAR(t.TransactionDate),
MONTH(t.TransactionDate),
t.AccountID
having Sum(t.Amount)>50000 ;

select * from Bonus;

------------------------------------------------------------------------------------

select AccountID, sum(Amount) as TotalDeposit
from Transactions
where TransactionType = 'Deposit'
group by AccountID;

select AccountID, sum(Amount) as TotalWithddraw
from Transactions
where TransactionType = 'Withdraw'
group by AccountID;

select
	c.CustomerName,
	a.AccountNumber,
	a.OpeningBalance + d.TotalDeposit - w.TotalWithdraw as CurrentBalance
from Customers c
join Accounts a
	on c.CustomerID = a.CustomerID
join(
	select AccountID, sum(Amount) as TotalDeposit
    from Transactions
    where TransactionType = 'Deposit'
    group by AccountID
)d
on a.AccountID = d.AccountID
join(
	select AccountID, sum(Amount) as TotalWithdraw
    from Transactions
    where TransactionType = 'Withdraw'
    group by AccountID
)w
on a.AccountID = w.AccountID;