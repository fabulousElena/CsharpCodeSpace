1����ʾ����������
-����������
	1�����TabControl
	2����ѯHallInfo����������TabPage
	3������ListView������TabPage��
	4����ѯTableInfo����������ListViewItem
-�����������У�ʹ�ñ�ǩ��ʾ��������ÿ����ǩ��ʹ��listview��ʾ����
	������Ϊʹ�á�����״̬
-��˫������������ǿ��У��򿪵��������ʹ�ã���������
	//������
	1��ΪOrderInfo��������ݣ�
	�޸Ĳ���״̬(2�����ݿ�״̬��3��UI״̬)

2�����
-������ʹ��ƴ�����������
-����ɵ��
	�����Ʒ�����
	�ٴε����Ʒ��������+1
	�������ı������޸�������ʹ��CellEndEdit�¼�
-��׷������
-����ʾ�ѵ��Ʒ
-��������
	select sum(oti.count*di.dprice) 
	from orderdetailinfo as oti
	inner join dishinfo as di
	on oti.dishid=di.did
	where oti.orderid=1
-���˲�
-��sqlite�л�ȡ��ǰʱ�䣺datetime('now', 'localtime')
-��1��չʾ���еĲ�Ʒ������ɸѡ��
	2��˫�����ˣ���Ҫ֪�����ĸ�������ģ�
select odi.oid,di.dTitle,di.dPrice,odi.count from dishinfo as di
inner join orderDetailInfo as odi
on di.did=odi.dishid
where odi.orderId=1

3������
-������UI
-��ѡ���Ƿ��Ա�����Ը��ݱ�š��绰��ѯ��Ա������ʹ�û�Ա������
-����ʾ���ѽ��
-�����ݻ�Ա��Ϣ���ܴ��ۣ���ʾ�ۿ۽��
-��ʵ�ֵĲ��������¶�����Ϣ�����²�����Ϣ�����ʹ������������»�Ա���
-�������ʹ�ã�
	������
	ͨ�����Ӷ���������
	���������ָ����Command����
	���������ύ����
	���쳣�»ع�����
