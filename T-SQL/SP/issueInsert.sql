CREATE proc issueInsert
@PrjName varchar(100),
@CRName varchar(100),
@IssueDesc varchar(500),
@Severity varchar(20),
@Status varchar(20),
@Developer varchar(50),
@Tester varchar(50),
@Lead  varchar(50),
@Remarks varchar(500)
as
begin

	select @PrjName =ISNULL(@PrjName,'')
	select @CRName =ISNULL(@CRName,'')
	select @IssueDesc =ISNULL(@IssueDesc,'')
	select @Severity =ISNULL(@Severity,'')
	select @Status =ISNULL(@Status,'')
	select @Developer =ISNULL(@Developer,'')
	select @Tester =ISNULL(@Tester,'')
	select @Lead =ISNULL(@Lead,'')
	select @Remarks = ISNULL(@Remarks,'')	
	
	insert into master..issueLog
	(PrjName,CRName,IssueDesc,Severity,Status,Developer,Tester,Lead,Remarks)
	values
	(@PrjName,@CRName,@IssueDesc,@Severity,@Status,@Developer,@Tester,@Lead,@Remarks)
	
	if @@ERROR <> 0
		select 'fail'	
	else
		select 'success..Please reload Grid'
end


