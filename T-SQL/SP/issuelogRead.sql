create proc issuelogRead
@PrjName varchar(50),
@CRName varchar(50)
as
begin
	if isnull(@CRName,'')<>''
	begin
		select *
		from master..issueLog(nolock)
		where PrjName = @PrjName
		and CRName = @CRName
	end
	else
	begin
		select *
		from master..issueLog(nolock)
		where PrjName = @PrjName		
	end
end
