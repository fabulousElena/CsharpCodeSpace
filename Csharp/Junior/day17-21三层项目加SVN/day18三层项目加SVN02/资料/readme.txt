0����ϰ
-�������һ�㿪��˳��model->dal->bll->ui
	����common�Ĵ����õ�ʱ����д

1����¼
-����¼���־�����Ա��
-����¼�ɹ��������ҳ��
	����ǵ�Ա������ʾ����Ʒ���������������������ˡ��Ĳ˵�
	����Ǿ����������Ϲ��ܵĻ��������ӡ���Ա�����Ĳ˵���
-���������


-->������������
ֵ����:int,boolean,char,decimal?
��������:null
�ɿ�ֵ����:
	int?:null,int

2����Ա������crud
-��������ṹ�������߼�ɾ��IsDelete
-���UI
-����ɻ�Ա��crud
-�����������ݻ�Ա�������绰�š�ɾ��״̬����
-����ɻ�Ա���͵�crud


select mi.*,mti.mTitle as MTypeTitle 
from MemberInfo as mi
inner join MemberTypeInfo as mti
on mi.mTypeId=mti.mid


dgvList.Rows[1].Selected = true;
