Alter procedure AddEmployee

@Name varchar(200),
@Address varchar(200),
@BasicPay float,
@Gender char(1),
@Phone bigint,
@NetPay float,
@Taxable float,
@IncomeTax float,
@Deductions float,
@Start_Date Date,
@Department varchar(200)
As
insert into EPLOYEE_PAYROLL(Name,Address,Gender,Phone,BasicPay,NetPay,Taxable,IncomeTax,Deductions,Start_Date,Department)values(@Name,@Address,@Gender,@Phone,@BasicPay,@NetPay,@Taxable,@IncomeTax,@Deductions,
@Start_Date,@Department);

EXEC [dbo].[AddEmployee]
		@Name='BRG',
		@Address='Mumbai',
		@Gender='M',
		@Phone=9765432176,
		@BasicPay=4578;
	

		select * from EPLOYEE_PAYROLL;
		
