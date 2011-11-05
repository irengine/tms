--adjust summary
update toolinventory set
	toolinventory.quantity=n.quantity,
	toolinventory.outquantity=n.outquantity,
	toolinventory.prescrapquantity=n.prescrapquantity,
	toolinventory.scrapquantity=n.scrapquantity,
	toolinventory.repairingquantity=n.repairingquantity
from toolinventory inner join 
(
	select i.toolid, quantity, 
		isnull(outquantity,0) as outquantity, 
		isnull(prescrapquantity,0) as prescrapquantity, 
		isnull(scrapquantity,0) as scrapquantity, 
		isnull(repairingquantity,0) as repairingquantity
	from
	(select toolid, sum(quantity) as quantity from toolinventoryhistory
	where account = 1000
	group by toolid) i
	left join
	(select toolid, sum(quantity) as outquantity from toolinventoryhistory
	where account = 2000
	group by toolid) o on i.toolid = o.toolid
	left join
	(select toolid, sum(quantity) as prescrapquantity from toolinventoryhistory
	where account = 3000
	group by toolid) p on i.toolid = p.toolid
	left join
	(select toolid, sum(quantity) as scrapquantity from toolinventoryhistory
	where account = 4000
	group by toolid) s on i.toolid = s.toolid
	left join
	(select toolid, sum(quantity) as repairingquantity from toolinventoryhistory
	where account = 5000
	group by toolid) r on i.toolid = r.toolid
) n on toolinventory.toolid = n.toolid

GO
