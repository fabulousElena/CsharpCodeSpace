0、复习
-》三层的一般开发顺序：model->dal->bll->ui
	对于common的代码用的时候再写

1、登录
-》登录（分经理、店员）
-》登录成功后进入主页面
	如果是店员，则显示“菜品管理、餐桌管理、开桌、结账”的菜单
	如果是经理，则在以上功能的基础上增加“店员管理”的菜单项
-》搭建主界面


-->插入数据类型
值类型:int,boolean,char,decimal?
引用类型:null
可空值类型:
	int?:null,int

2、会员及类型crud
-》分析表结构：采用逻辑删除IsDelete
-》搭建UI
-》完成会员的crud
-》搜索：根据会员姓名、电话号、删除状态查找
-》完成会员类型的crud


select mi.*,mti.mTitle as MTypeTitle 
from MemberInfo as mi
inner join MemberTypeInfo as mti
on mi.mTypeId=mti.mid


dgvList.Rows[1].Selected = true;
