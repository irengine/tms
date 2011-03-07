update ToolCategory set code = replace(code, 'G9', '99') 
update ToolCategory set code = replace(code, 'G', '0') 

update Tool set code = replace(code, 'G9', '99') 
update Tool set code = replace(code, 'G', '0') 


update tool set length=load2,load2=length  

update tool set Dimensions = 
     case when len([diameter])!=0 then '¦Õ' + [diameter] + 'mm'  else '' end
	+case when len([load2])!=0 then [load2] + 'T' else '' end
	+case when len([length])!=0 then '¡Á' + [length] + 'm' else '' end
	+case when len([Description])!=0 then ', ' + [Description] else '' end from Tool



update Unit set Code =REPLACE(code,'-','_')

alter table TMS.dbo.OutboundOrder 
add 
	AddTime DateTime2(7) null,
	ReturnTime DateTime2(7) null
go
