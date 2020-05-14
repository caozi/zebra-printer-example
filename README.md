# zebra-printer-example
手边有两台闲置的斑马打印机（ZDesigner GK888t (EPL)）和一堆标签纸，最近又刚好需要设计一个标签用于科室工作。发现网上没有很好的教程，所以下面把我如何完成这个工作的流程详细的说一遍。

## 第一步：用ZebraDesigner设计标签
1.  下载[zebra官网](https://www.zebra.cn/us/en.html)提供[ZebraDesigner软件](https://www.zebra.cn/us/en/support-downloads/printer-software/zebra-designer-3-downloads.html)，安装完之后，新建一个标签然后打印，看看能不能在纸带上打印出来。
![ZebraDesigner截图](https://github.com/caozi/zebra-printer-example/blob/master/screenshot/zebradesigner1.png)
2.  使用ZebraDesigner软件设计你想要的标签，打印时选择打印至文件，这样你会得到一个prn结尾的文件，这个文件保存了打印你设计的标签的EPL命令。
![ZebraDesigner打印到prn文件](https://github.com/caozi/zebra-printer-example/blob/master/screenshot/zebradesigner2.png)

## 第二步：将prn文件中的EPL命令发送给斑马打印机（ZDesigner GK888t (EPL)）
 用windows记事本打开prn文件，prn文件的内容很简单，找到你想打印的内容，比如我想打印的号是555055，如果想让打印机打印别的号码，只需要替换掉555055就可以，具体代码可以参考private string GenerateLabels(int startLabelNumbers, int numberOfLabelsToGenerate)函数，很简单的。
 ![记事本打开prn文件](https://github.com/caozi/zebra-printer-example/blob/master/screenshot/prn1.png)

就这么简单

