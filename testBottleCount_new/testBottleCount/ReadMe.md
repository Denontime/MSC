

1.Mqtt相关
接收，发送消息

2.VisionBox相关
Camera相关设置准备（IP等）Camera使用自己封装的SDK进行连接
Scanner 相关设置准备(Port等) scanner是使用TCP链接，作为TCP服务端，只需要打开指定端口即可

初始化camera
初始化scanner

注册回调函数（连接，断开，异常，数据处理）

2.1 scanner相关
接收到的数据处理

2.2 camera相关
接收到的图像处理


3.API相关（与服务器交互，取数据）
HttpService.RequestModuleInfo(""); 根据设备ID 获取当前model相关数据， 反序列化成 ModuleModel
HttpService.RequestPickProductList(barcode,BottlePickID)  根据当前的scanner 和箱子所处的位置，获取产品列表（List<ProductModel>）
HttpService.RequestTotalPickCount(barcode,BottlePickID)  根据当前的scanner 和箱子所处的位置，获取这次应该QA的总数量
HttpService.SendFinalQAStatus(barcode,BoxKey,List<ProductModel>) 发送qa结果，并更新状态
HttpService.SaveQAImage(BoxKey,image,Point) 保存图像数据

界面需要做的改动
根据Pick状态需要显示每个产品的pick的数量
能够修改pick的数量
Reqa时，能够根据界面每个产品的pick数量重新进行qa
点击Release时候能够发送mqtt消息进行强制放行，并更新状态
设置提示区，提示当前箱子的工作状态

请注意释放cachebox对象


