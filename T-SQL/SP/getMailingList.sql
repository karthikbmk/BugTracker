CREATE proc getMailingList
@developer varchar(50),
@Lead	varchar(50)
as
begin
	select isnull(EmailID ,'')
	from master..userDetails with(nolock)
	where (
			   Name in (@developer,@Lead) or
			   Role  = 'Manager'
		   )
	and param1 = 'IN_MAIL_LOOP'
	order by param2 asc
end

