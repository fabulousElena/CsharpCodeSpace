1��ƴ�����ʹ��
-����vsintlpack1.zip��΢���ṩ��һ��ƴ�����
-�����CHSPinYinConv.msi���ڻ�ȡƴ������
-�����ð�װ·����
C:\Program Files (x86)\Microsoft Visual Studio International Pack\Simplified Chinese Pin-Yin Conversion Library\
-����ChineseChar�����ַ�������������Pinyins��ȡƴ��
-���������װ��Common���еİ������У�����ʹ��

2����Ʒ�����crud
-����Ʒ���crud
-����Ʒcrud

��ҵ��ÿ��С�����Ŀ

dishinfo	dtypeid
dishtypeinfo	did

select di.*,dti.dtitle 
from dishinfo as di
inner join dishtypeinfo as dti
on di.dtypeid=dti.did
where di.dIsDelete=0 and dti.dIsDelete=0
and di.dtitle like '%����%'
