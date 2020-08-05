1、拼音组件使用
-》包vsintlpack1.zip是微软提供的一个拼音组件
-》组件CHSPinYinConv.msi用于获取拼音功能
-》引用安装路径：
C:\Program Files (x86)\Microsoft Visual Studio International Pack\Simplified Chinese Pin-Yin Conversion Library\
-》类ChineseChar根据字符创建对象，属性Pinyins获取拼音
-》将代码封装到Common层中的帮助类中，方便使用

2、菜品及类别crud
-》菜品类别crud
-》菜品crud

作业：每个小组的项目

dishinfo	dtypeid
dishtypeinfo	did

select di.*,dti.dtitle 
from dishinfo as di
inner join dishtypeinfo as dti
on di.dtypeid=dti.did
where di.dIsDelete=0 and dti.dIsDelete=0
and di.dtitle like '%猪肉%'
