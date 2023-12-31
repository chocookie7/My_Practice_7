# 实验六  Web项目前后端分离开发  
## 一、掌握前后端项目依赖与配置
#### 1.   分别写出后端项目WebBackend和WebBackend2的pom依赖（只要求写artifactId名称，并分别顺序编号）。
【答】
| 编号 |  WebBackend  |  WebBackend2  | 
| ---- | ---- | ----- |
1|spring-boot-starter-web|spring-boot-starter-web
2|spring-boot-starter-data-jpa|spring-boot-starter
3|spring-boot-devtools|spring-boot-devtools
4|mysql-connector-j|mysql-connector-j
5|druid-spring-boot-starter| 未配置数据源，spring会自动配置的
6|Lombok|Lombok
7|spring-boot-starter-test|spring-boot-starter-test
8|java-jwt|java-jwt
9| | junit


#### 2. 分别截图项目WebBackend和WebBackend2的配置文件代码。
【答】  
WebBackend的配置文件：  
![image](https://github.com/chocookie7/My_Practice_7/assets/96895927/11874f64-b1cb-4a11-9581-9ce0e8961200)

WebBackend2的配置文件：  
![image](https://github.com/chocookie7/My_Practice_7/assets/96895927/bcbdd731-1cab-40d9-88fd-e85e9aaf061f)

#### 3. 比较项目WebBackend和WebBackend2的启动文件代码的异同点。

相同：  
(1)都使用了@SpringBootApplication 注解，表明是 Springboot 的主启动类。  
(2)重写了接口的 addCorsMappings()方法，允许跨域请求。    
(3)重写了接口的 addInterceptors()方法，配置拦截功能。 

不同点：  
(1)WebBackendApplication实现接口WebMvcConfigurer。  
(2)启动类 WebBackend2Application 未实现接口，但对返回值类型为 WebMvcConfigurer 的方法，setWebMvcConfiguration()使用@Bean 注解。

#### 4. 分别截图前端项目webfront生产依赖和项目构建主文件main.js的代码。
生产依赖如图：  
![image](https://github.com/chocookie7/My_Practice_7/assets/96895927/264f0df8-ff08-43b9-82e0-a437a767f987)
项目主文件如图：  
![image](https://github.com/chocookie7/My_Practice_7/assets/96895927/1f8c3ba7-5f35-4014-89d8-875a65d2415a)

#### 5.为什么三个项目可以同时运行？前端项目如何切换使用不同的后端项目？
【答】  
（1）因为不同项目运行端口不同，并不冲突，可同时运行。  
（2）在 main.js 中，可以切换不同后端项目，通过切换 axios 的基地址，如下所示：  
![image](https://github.com/chocookie7/My_Practice_7/assets/96895927/8dc39621-b083-4b95-9117-1e5145515cb2)

## 二、分析后端项目WebBackend，掌握后端项目的开发技术
#### 1. Token信息由哪三个部分组成？项目在哪个控制器的哪个方法里生成JWT Token信息？
【答】  
(1)分别由  
- Header（头部） 作用：定义类型和加密算法  
- Payload（数据）  作用:存放有效信息  
- Signature（签名）  作用：验证令牌的完整性  
  
在AdminController 控制器的 adminLogin 方法里生成 JWT Token 信息：  
![image](https://github.com/chocookie7/My_Practice_7/assets/96895927/da9df26d-8d3b-4cdb-999f-73a0aeb587cf)

  
#### 2. 截图使用Postwoman测试生成Token信息？截图在官网https://jwt.io解码和校验Token的结果。
【答】  
![image](https://github.com/chocookie7/My_Practice_7/assets/96895927/855f3fa3-cc7b-4750-99b6-024417819008)  
![image](https://github.com/chocookie7/My_Practice_7/assets/96895927/3f87a2af-d235-47fe-a0de-c1612cbf38bd)  

#### 3. 截图学院控制器CollegeController方法updateCollege()的代码，为什么方法参数未使用实体类类型？
【答】  
![image](https://github.com/chocookie7/My_Practice_7/assets/96895927/c7962c16-0375-459d-9e08-4fde43aa5b01)  
在updateCollege 方法中，参数是 Map<String, String> 对象而不是实体类 College ，这是因为该方法需要处理三个键值对（"newName"、"oldName"、"xuhao"），而实体类 College 只有两个字段（"name"和"xuhao"）。通过 Map<String, String> 对象，我们可以灵活的传递和处理不同的键值对。

#### 4.分别截图类MajorDto和专业控制器MajorController方法updateMajor()的代码，并指出DTO对象与实体类对象的区别与联系。
【答】  
![image](https://github.com/chocookie7/My_Practice_7/assets/96895927/d98c611f-179d-4cfa-a9a8-3bec23af276d)  
  
![image](https://github.com/chocookie7/My_Practice_7/assets/96895927/78dc552b-4bc2-459e-a8aa-ad6da0687373)

DTO 对象用于数据传输和格式转换，可以定义一组特定的字段，用于满足特定业务场景或前端页面的数据需求，减少数据传输量，不会持久化。
实体类对象用于与数据表进行映射，主要关注数据的持久化和业务逻辑。




## 三、分析后端项目WebBackend与WebBackend2的异同点
#### 1. 假定使用Spring Boot+Sping Data JPA的后端项目WebBackend已经完成，如何改写成Spring Boot+MyBatis Plus？给出主要步骤。
【答】  



#### 2. 项目WebBackend的DAO层接口继承什么接口？该泛型接口包含哪两个参数类型？操作方法的注解与普通查询的注解有何差别？
【答】
1、DAO层继承JpaRepository<T,ID>接口
2、实体类T，实体类的主键类型ID
3、普通查询使用`@Query`注解，而CRUD使用的注解在普通查询上加了`@Modifying、@Transcational`注解

#### 3. 项目WebBackend2的DAO层继承什么接口？该泛型接口的参数类型是什么？哪个映射接口使用了自定义方法？对应的XML映射文件一般要放在什么位置？
【答】
1、继承BaseMapper<T>接口
2、实体类类型
3、AdminMapper映射接口使用了自定义方式
4、一般放在resources文件中对应的mapper文件中


#### 4. 两个后端项目是如何设置允许跨域请求的？分别截图相关代码。
【答】
```
@Override
public void addCorsMappings(CorsRegistry registry){  //统一设置允许跨域请求
    registry.addMapping("/**")  //匹配任意URL路径
        .allowCredentials(true)  //允许携带凭证
        .allowedOriginPatterns("*")  //允许所有的请求来源
        .allowedMethods("GET","POST")  //允许的请求方法
        .allowedHeaders("*")   //允许所有的请求头
        .exposedHeaders("*");  //暴露所有的响应头
}
```

## 四、分析前端项目webfront，掌握前端项目的开发技术
#### 1. 截图App.vue组件的方法adminLogin()代码，并加框标记建立sessionStorage存储的代码。执行登录操作后，按F12打开浏览器调试窗口的Application选项，截图会话存储的信息。
【答】


#### 2. 截图ManageCollege.vue组件的方法updateCollege()代码，并加框标记使用请求头携带Token的代码。
【答】


#### 3. 能否在不登录的情况下，使用Postwoman测试出来的Token信息写入浏览器会话信息，实现对管理功能的使用？并简要说明其理由。
【答】   
可以。  
理由：请求会被拦截并进行身份验证，只要携带的token信息有效就会被放行。因此，使用postwoman测试用户登录，获取一个有效的token，手动输入到application的session storage（浏览器会话存储信息）的键值对中，就可以实现在不登录的情况下管理功能的使用。  

## 【小结】
#### 1.试比较前后端分离项目与不分离项目的异同点。
【答】  
相同：
不同：

#### 2.后端项目的服务层里，能否不写接口？为什么建议要写接口？
【答】  
1、可以，但是写接口有利于代码实现松耦合。  
2、方便日后添加功能，直接调用接口就可以实现，不会影响原来的代码。利于拓展。

#### 3.后端你个人偏向于使用Spring Boot+Spring Data JPA？还是Spring Boot+MyBatis Plus？为什么？
【答】  
Spring Boot+MyBatis Plus。  
提供了基础CRUD功能的基础方法，使用xml映射文件进行配置后即可使用，对于数据库的搜索更加的自由。

#### 4.如何运行打包后的后端项目？	
【答】  
打包后的后端一般是jar文件，在对应的命令行输入以下指令就可以运行了
> java -jar project-name.jar

#### 5. 在前后端分离项目里，Nginx服务器有什么作用？
【答】  
Nginx 服务器充当**静态服务器**，**提供访问静态页服务**，将 Vue 项目的构建输出目录作为根目录进行访问。当客户端请求该 Nginx 服务器时，Nginx 将直接提供静态文件，并未代理到其他目标服务器（即未使用反向代理功能）。
