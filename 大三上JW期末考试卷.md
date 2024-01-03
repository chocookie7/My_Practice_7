# 选择题  
第1题  
在IDEA2023里编写代码时，注释选中的若干行代码的快捷键是______。  
Ctrl+Y  
Ctrl+D  
**Ctrl+Shift+/ （答案）**  
Ctrl+V  

第2题  
在Vue3项目的package.josn文件里，用于发送异步请求的依赖是_______。  
**axios （答案）**  
element-plus  
vue-router  
vuex  

第3题  
下列HTML标签中，表示下拉列表选择的是___________。  
A.form  
B.table  
C.img  
**D.select （答案）**  

第4题  
下列关于请求转发与重定向的说法中，不正确的是______  
A.重定向使用响应对象的方法sendRedirect()实现  
B.请求转发需要先使用请求对象的方法getRequestDispather()获得转发器，再使用方法forward()  
C.请求转发不会产生新的请求对象，而重定向会产生新的请求对象  
**D.重定向和请求转发时，浏览器地址栏的url都会相应地变化 （答案）**  

第5题  
使用Servlet+JavaBean+JSP实现的MVC项目里，Servlet的作用是_______。  
视图  
模型  
**控制器 （答案）**  
模型与控制器  

第6题  
下列关于MyBatis Plus框架的说法中，不正确的是__________。  
MyBatis Plus框架的功能是对象关系映射  
MyBatis Plus框架将对实体类对象的操作映射为对数据库表的操作  
MyBatis Plus框架将实体类属性映射为数据库表的字段  
**MyBatis Plus框架只能应用Java Web项目，而不能应用Java桌面项目 （答案）**  

第7题
在MyBatis/MyBatis Plus框架提供的API里，使用接口____________类型的对象的方法getMapper(映射接口名.class)，获取对应的映射接口类型的对象。  
Resources  
SqlSessionFactoryBuilder  
SqlSessionFactory  
**SqlSession （答案）**  

第8题  
Spring MVC项目的控制器和方法，都是使用___________注解进行路径请求映射。  
@Controller  
@RequestBody  
@ResponseBody  
**@RequestMapping （答案）**  
  
第9题  
下列关于Spring Boot框架的说法中，不正确的选项是_________。  
Spring Boot项目使用Spring Boot框架提供的父工程 ，并具有自动配置功能  
使用Spring Boot向导创建项目时，根据所需功能自动在pom.xml里生成依赖项  
Spring Boot框架默认了Spring、Spring MVC、Spring Data JPA和MyBatis Plus等框架的使用方式  
**Spring Boot是一个全新的框架，与Spring、Spring MVC等框架无关 （答案）**  

第10题  
下列关于Web项目前后端分离开发的说法中，不正确的选项是________。  
约定开发的接口及其规范后，前端和后端可独立开发和部署到服务器  
后端一般使用Spring Boot开发，因为它有默认配置和内置的Tomcat  
前端一般使用Vue3框架开发，因为它有丰富的库和插件，如axios库、element plus UI组件库和vue-router插件等  
**后端项目不需要做特殊的配置，前端就能访问后端 （答案）**  

# 判断题    
第1题IDEA2023没有内置Maven插件。    
学生答案：F    
标准答案：F    

第2题在使用jQuery的页面里，必须使用标签<script>引入jQuery脚本库文件。    
学生答案：    
标准答案：T    

第3题Servlet是运行于Web服务器端的Java程序。在MVC架构的Web项目里，它能够接收用户请求、调用业务逻辑组件处理数据，最后将结果通过请求对象转发至视图页面。  
学生答案：F  
标准答案：T  

第4题使用JDBC访问MySQL8时，连接字符串可以不通过serverTimezone指定时区信息  
学生答案：F  
标准答案：F  
  
第5题在Servlet+MyBatis Plus+JSP构建的Web项目的框架配置文件里，每个映射接口通过标签<mapper resource="带包名的接口名.class"/>进行配置。  
学生答案：T  
标准答案：F  
  
第6题MyBatis Plus和Spring Data JPA都属于对象关系映射框架，都提供了DAO层的通用接口与实现。  
学生答案：T
标准答案：T

第7题Spring框架的核心功能分别是依赖注入和面向切面编程。  
学生答案：T  
标准答案：T  
  
第8题Spring Boot项目包含父工程起步器依赖，因而可以实现对其他起步器依赖的版本进行统一控制。  
学生答案：T  
标准答案：T  

第9题Spring Boot框架对SSM整合项目的使用做了默认的实现，实现了框架的零配置。  
学生答案：T  
标准答案：T  

第10题前后端分离开发的后端项目里，必须配置允许跨域请求和访问。  
学生答案：T  
标准答案：T  

# 填空题
第1题用户通过浏览器向Web服务器发送的请求，主要有get和______两种类型。（字母全部小写）  
学生答案：post  
标准答案：post  

第2题在JavaScript脚本里添加语句___________，可进行客户端脚本调试。  
学生答案：debugger  
标准答案：debugger  

第3题JDBC提供了访问数据库的四个接口，分别是Driver、Connection、Statement和ResultSet。其中，表示数据库连接对象类型的接口是_________。  
学生答案：  
标准答案：Connection  

第4题  

调用静态方法MyBatisUtil.getSqlSession()的返回值类型是_________。（要求严格字母大小写）  
学生答案：SqlSessionFactory  
标准答案：SqlSession  

第5题MyBatis Plus框架提供的泛型通用映射接口是__________<T>。其中，T表示实体类类型。  
学生答案：BaseMapper  
标准答案：BaseMapper  

第6题  

学生答案：value  
标准答案：ref  

第7题对Spring Boot项目的启动类应使用的注解是__________。  
学生答案：@SpringBootApplication  
标准答案：@SpringBootApplication  

第8题	在前后端分离开发的后端项目里，控制器所有的方法都是响应体返回。因此，控制器注解一般使用___________。  
学生答案：@ResponseBody  
标准答案：@RestController  
  
阅读理解题  
第1题  
根据如下Web项目结构图，说明使用【Servlet+JDBC+JSP】原生开发的主要特点。（至少指出三点）  

学生答案：  
1、进行简单的分层结构。通过分为controller层、dao层、sevice层，三层对程序的架构进行解耦，便于项目后期的拓展，同时将数据处理与程序逻辑分开，减轻Servlet的压力。  
2、需要手动配置JDBC进行数据库连接；  
3、需要手动完成控制器的实现类；  
4、需要分别对Servlet框架单独进行实现；  
5、使用javaBean对实体类进行简单的封装。  

标准答案：  
（1）程序使用MVC架构，依次分为DAO层、Service层和控制层。  
（2）DAO定义了接口及其实现，使用原生的JDBC技术访问数据库做实现，供服务层调用。  
（3）Service层定义了接口及其实现，使用DAO层做实现，供控制层调用。  
（4）控制层的控制器类继承HttpServlet并使用@WebServlet()注解。  
（5）视图层使用JSP，通常还会使用EL表达式和JSTL标签库。

第2题已知会员管理项目MemManaNoSpring的文件系统如下：  
请简要描述该项目的技术构建。（至少回答三点）  
学生答案：  
1、遵循“controller、dao、service“三层架构对项目进行解耦，便于后面的拓展；  
2、配置了datasource.perpoties数据源，表明这是一个springmvc项目。  
3、使用了config.xml为后缀的文件，表示对该框架进行了整合，其中springmvc框架可以单独进行整合的。  
4、实现了公共的页面交互效果。  
  
标准答案：  
（1）MemManaNoSpring是程序分层的MVC项目。  
（2）独立应用和配置了MyBatis Plus和Spring MVC两个框架，未使用Spring框架做整合。  
（3）Spring MVC框架配置文件spingmvc-config.xml供项目配置文件web.xml调用。  
（4）MyBatis Plus框架是对原生JDBC技术的再封装，Spring MVC框架是对原生技术Servlet的再封装。  
（5）视图层使用JSP模板引擎。  

第3题已知会员管理项目MemMana的文件系统如下：  

学生答案：  
1、遵循“controller-dao-service”分层架构，便于项目的解耦，方便后面的拓展。  
2、继承了父工程起步器依赖，因而可以实现对其他起步器依赖的版本进行统一控制。  
3、对spring、Mybatis-Plus等框架的使用做了默认的实现，实现框架零配置。  
4、使用了application启动类，表示这是一个SpringBoot框架的项目。  
5、使用了templates文件存放对应页面视图文件  
6、通过框架，自动实现控制器方法与实体类的配置。  

标准答案：  
1）MemMana属于Spring Boot项目，MemManaApplication是启动文件。  
（2）项目使用了MyBatis Plus框架，无需写框架配置文件（零配置）。  
（3）项目也使用程序分层的MVC架构，视图层使用Thymeleaf模板引擎，位于专用文件夹resources/。  
（4）项目配置文件application.yaml位于专用文件夹resources/，主要配置数据源的相关信息。  

第4题 试比较前后端分离项目与不分离项目的不同点。（至少指出三个不同点）  
学生答案：  
1、跨域访问问题。前后端分离的项目必须允许跨域访问，前后端不分离的项目不需要跨域访问。  
2、配置方式不同。前后端分离的项目的交互方式是json数据通过api接口进行交互，并且后端的结构不是SpringMVC结构，而前后端不分离的项目一般使用SpringMVC模式进行交互。  
3、注释方式不同。前后端分离项目中，控制器需要添加@ResponseBody的注解，方法需要添加@RequestBody的注解；而前后端不分离的项目不需要添加@ResponseBody、@RequestBody注解。  

标准答案：  
（1）开发和部署方式不同。在前后端分离项目里，前端和后端独立开发和部署，前端以JSON格式与后端API进行交互，后端项目不是MVC架构（不包含视图）。非前后端分离项目一般采用MVC架构，控制器将结果数据以请求转发的方式交给视图展示。  
（2）方法及参数注解不同。在前后端分离项目里，后端控制器方法使用@ResponseBody注解，方法参数使用@RequestBody注解。在非前后端分离项目中，通常情况下，方法不使用@ResponseBody注解，方法参数不使用@RequestBody注解。  
（3）用户认证方式不同。前后端非分离项目可以使用简单的基于Cookie的Session认证，而前后端分离项目使用会话存储的JWT Token等验证方式。  
（4）跨域访问问题。前后端分离项目必须配置允许跨域访问，非分离项目则不存在跨域访问问题。  


# 完形填空题  
第1题  
已知《高校专业信息管理系统》Web项目使用前后端分离开发。后端项目里，管理员登录成功后，返回JWT Token供前端项目使用。  
实体类Admin分别定义了获取用户名和密码的方法getName()和 getPwd()。  
接口AdminService定义了方法：ResponseBean getOneAdmin(String name, String pwd)  
其中，统一响应类ResponseBean定义了获取状态码方法getCode()。状态码为1时，表示登录成功。  
工具类JWTUtil提供了生成相应于name信息的Token字符串的静态方法：String generateToken(Map<K,V>)。  
请在下面控制器代码的空白处，填写实现代码。  



学生答案：
```
Map<String,String> tokenMap=new HashMap<>();
if(tokenMap.getCode==1){
    ResponseBean responseBean=adminService.getOneService(admin.getName(),admin.getPwd());
    token.put("name",admin.getName());
    token.put("token",JWTUtil.generateToken(tokenMap));
    return ResponseBean.success(tokenMap);
}
```
标准答案：
```
ResponseBean responseBean = adminService.getOneAdmin(admin.getName(), admin.getPwd());
if(responseBean.getCode()==1){   
   Map<String, String> tokenMap = new HashMap<>();
      tokenMap.put("name", admin.getName());  
   tokenMap.put("token", JWTUtil.generateToken(tokenMap)); 
      return ResponseBean.success(tokenMap);
}
return responseBean;  
```
第2题
《高校专业信息管理系统》前端Vue3项目的根组件App.vue的数据属性及计算属性的定义如下：


请在App组件的用户登录方法代码空白处，填写实现代码。

学生答案：
```
this.userId=res.data.data.name;
window.sessionStorage.getItem("name",res.data.data.name);
window.sessionStorage.getItem("token",res.data.data.token);
```
标准答案：
```
this.$message.success("登录成功！")
this.userId = res.data.data.name
this.isDisabled = false 
this.showAdminLoginButton = !this.showAdminLoginButton   
this.showLoginDialog = !this.showLoginDialog 
window.sessionStorage.setItem("token", res.data.data.token) 
window.sessionStorage.setItem("name", res.data.data.name)  
```
