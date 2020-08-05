1、显示厅包及餐桌
-》开发步骤
	1、添加TabControl
	2、查询HallInfo，遍历创建TabPage
	3、创建ListView，加入TabPage上
	4、查询TableInfo，遍历创建ListViewItem
-》在主窗口中，使用标签显示厅包，在每个标签中使用listview显示餐桌
	餐桌分为使用、空闲状态
-》双击餐桌，如果是空闲，则开单，如果是使用，则继续点菜
	//开单：
	1、为OrderInfo表插入数据；
	修改餐桌状态(2、数据库状态，3、UI状态)

2、点菜
-》可以使用拼音、分类检索
-》完成点菜
	点击菜品则添加
	再次点击菜品则让数量+1
	可以在文本框中修改数量：使用CellEndEdit事件
-》追加消费
-》显示已点菜品
-》计算金额
	select sum(oti.count*di.dprice) 
	from orderdetailinfo as oti
	inner join dishinfo as di
	on oti.dishid=di.did
	where oti.orderid=1
-》退菜
-》sqlite中获取当前时间：datetime('now', 'localtime')
-》1、展示所有的菜品（可以筛选）
	2、双击项点菜（需要知道是哪个订单点的）
select odi.oid,di.dTitle,di.dPrice,odi.count from dishinfo as di
inner join orderDetailInfo as odi
on di.did=odi.dishid
where odi.orderId=1

3、结账
-》创建UI
-》选择是否会员，可以根据编号、电话查询会员，可以使用会员余额结账
-》显示消费金额
-》根据会员信息享受打折，显示折扣金额
-》实现的操作：更新订单信息，更新餐桌信息，如果使用余额结账则更新会员余额
-》事务的使用：
	打开连接
	通过连接对象开启事务
	将事务对象指定给Command对象
	在正常下提交事务
	在异常下回滚事务
