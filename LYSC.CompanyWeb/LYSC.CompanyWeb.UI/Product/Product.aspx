<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="LYSC.CompanyWeb.UI.Product.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
<title>软件产品--北京华科世佳软件开发有限公司</title>
<meta name="robots" content="index, follow" />
<meta name="author" content="北京多维网讯科技有限公司" />
<meta name="keywords" content="软件开发、房地产业管理类软件、新建商品房网上备案系统、存量房网上备案系统、统计与发布系统、项目管理系统、从业主题管理系统、产权产籍管理系统、测绘成果及管理系统"/>
<meta name="description" content="北京华科世佳软件开发有限公司地处国家计算机应用软件研发腹地——北京市海淀区上地信息产业基地，具有明显的人才优势、技术优势和环境优势。我公司在2004年12月通过了北京市科委的软件企业认证和北京市软件行业协会软件产品的认定。" />
<link href="../../style/style.css" type="text/css" rel="stylesheet" />
<link href="../../style/pageStyle.css" rel="stylesheet" />
</head>
<body class="body_column">
    <form id="form1" runat="server">
    <div id="wrap_column">

        <%--显示网站导航和网站主背景--%>
        <div id="header_column" class="header_product">
            <h1 class="logo_column"><a href="../../index.html"><img src="../../Images/logo.png" width="179" height="55" alt="北京华科世佳软件开发有限公司" /></a></h1>
         
            <div class="nav_column">
         <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="754" height="37" id="FlashID" title="北京华科世佳软件开发有限公司">
           <param name="movie" value="../../flash/sub_fla.swf" />
           <param name="quality" value="high" />
           <param name="wmode" value="transparent" />
           <param name="swfversion" value="8.0.35.0" />
           <!-- 此 param 标签提示使用 Flash Player 6.0 r65 和更高版本的用户下载最新版本的 Flash Player。如果您不想让用户看到该提示，请将其删除。 -->
           <param name="expressinstall" value="../../script/expressInstall.swf" />
           <!-- 下一个对象标签用于非 IE 浏览器。所以使用 IECC 将其从 IE 隐藏。 -->
           <!--[if !IE]>-->
           <object type="application/x-shockwave-flash" data="../../flash/sub_fla.swf" width="754" height="37">
             <!--<![endif]-->
             <param name="quality" value="high" />
             <param name="wmode" value="transparent" />
             <param name="swfversion" value="8.0.35.0" />
             <param name="expressinstall" value="../../script/expressInstall.swf" />
             <!-- 浏览器将以下替代内容显示给使用 Flash Player 6.0 和更低版本的用户。 -->
             <div>
               <h4>此页面上的内容需要较新版本的 Adobe Flash Player。</h4>
               <p><a href="http://www.adobe.com/go/getflashplayer"><img src="http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif" alt="获取 Adobe Flash Player" width="112" height="33" /></a></p>
             </div>
             <!--[if !IE]>-->
           </object>
           <!--<![endif]-->
         </object>
        </div>
        </div>

        <%--显示网站主题图片内容--%>
        <div id="main_product">
   		    <h2 class="position">华科软件产品</h2>

            <%--显示网站信息总图片显示--%>
             <%--    <div class="wrap_listprd">
               <dl class="list_prd">
                  <dt><a class="graylink" href="NewHouse.aspx">新建商品房网上备案系统</a></dt><!--./images/img_prd_NewHouse.jpg-->
                  <dd><a href="NewHouse.aspx"><img src='<%=GetImageUrlByType("00000014")%>' width="174" height="80" alt="新建商品房网上备案系统" /></a></dd>
                </dl>
                <dl class="list_prd">
                  <dt><a class="graylink" href="StockHouse.aspx">存量房网上备案系统</a></dt>
                  <dd><a href="StockHouse.aspx"><img src='<%=GetImageUrlByType("00000015")%>' width="174" height="80" alt="存量房网上备案系统" /></a></dd>
                </dl>
                <dl class="list_prd">
                  <dt><a class="graylink" href="Statistics.aspx">统计与发布系统</a></dt>
                  <dd><a href="Statistics.aspx"><img src='<%=GetImageUrlByType("00000018")%>' width="174" height="80" alt="统计与发布系统" /></a></dd>
                </dl>
                <dl class="list_prd">
                  <dt><a class="graylink" href="ProjectManagement.aspx">项目管理系统</a></dt>
                  <dd><a href="ProjectManagement.aspx"><img src='<%=GetImageUrlByType("00000016")%>' width="174" height="80" alt="项目管理系统" /></a></dd>
                </dl>
                <dl class="list_prd">
                  <dt><a class="graylink" href="Practitioners.aspx">从业主体管理系统</a></dt>
                  <dd><a href="Practitioners.aspx"><img src='<%=GetImageUrlByType("00000019")%>' width="174" height="80" alt="从业主体管理系统" /></a></dd>
                </dl>
                <dl class="list_prd">
                  <dt><a class="graylink" href="Property.aspx">产权产籍管理系统</a></dt>
                  <dd><a href="Property.aspx"><img src='<%=GetImageUrlByType("00000012")%>' width="174" height="80" alt="产权产籍管理系统" /></a></dd>
                </dl>
                <dl class="list_prd">
                  <dt><a class="graylink" href="Mapping.aspx">测绘成果及管理系统</a></dt>
                  <dd><a href="Mapping.aspx"><img src='<%=GetImageUrlByType("00000011")%>' width="174" height="80" alt="测绘成果及管理系统" /></a></dd>
                </dl>
                <dl class="list_prd">
                  <dt><a class="graylink" href="MaintenanceFunds.aspx">维修资金管理系统</a></dt>
                  <dd><a href="MaintenanceFunds.aspx"><img src='<%=GetImageUrlByType("00000013")%>' width="174" height="80" alt="维修资金管理系统" /></a></dd>
                </dl>
                <dl class="list_prd">
                  <dt><a class="graylink" href="HousingSecurity.aspx">住房保障管理体系</a></dt>
                  <dd><a href="HousingSecurity.aspx"><img src='<%=GetImageUrlByType("00000010")%>' width="174" height="80" alt="住房保障管理体系" /></a></dd>
                </dl>
                <dl class="list_prd">
                  <dt><a class="graylink" href="Transaction.aspx">房产交易资金监管系统</a></dt>
                  <dd><a href="Transaction.aspx"><img src='<%=GetImageUrlByType("00000017")%>' width="174" height="80" alt="房产交易资金监管系统" /></a></dd>
                </dl>--%>

            <%--自己写的显示图片的信息--%>
            <div class="wrap_listprd">
            	
                  <%foreach (var hksmain in mainShow)
	                {%>
                <dl class="list_prd">
                      <dt><a class="graylink" href="NewHouse.aspx"><%=hksmain.title %></a></dt><!--./images/img_prd_NewHouse.jpg-->
                      <dd>
                          <a href="NewHouse.aspx">
		                        <img src='<%=hksmain.picUrl %>' width="174" height="80" alt='<%=hksmain.title %>' />
                                                </a>
                      </dd>
                </dl>
             <%} %> 
          </div>

            <%--显示分页信息--%>            
      	    <div class="clear"></div>
            <div class="pages"><%=NavPager %></div>
        </div>


       <%-- 显示网站尾部信息--%>
        <div id="footer_column">
      	    <span class="copyright"></span><span class="frdlink">友情链接：<asp:DropDownList 
                ID="DropDownList1" runat="server">
            </asp:DropDownList>
        </span>&nbsp;</div>

    </div>
    </form>
</body>
</html>
