# 实验五 Spring Boot项目开发
## 一、打开项目SpringBootBasics，掌握Spring Boot项目结构、热部署功能、单元测试、Thymeleaf模板引擎及项目打包
#### 1.  分别 指出pom.xml里5个依赖项spring-boot-starter-web、spring-boot-starter-test、spring-boot-devtools、lombok和spring-boot-starter-thymeleaf的作用，并指出Spring Initializr模板创建Spring Boot项目时，哪个依赖是自动引入的？
【答】  
|名称|作用|
| ---- | ---- |
spring-boot-starter-web|实现构建web需要应用程序
spring-boot-starter-test|实现单元测试和集成测试
spring-boot-devtools|实现热部署
Lombok| 实体类注解
spring-boot-starter-thymeleaf|开发者工具
|spring-boot-starter-test|自动生成基础起步器依赖|
 
#### 2. 本项目能使用热部署功能吗？说明其原因。
【答】
> 可以，因为添加了`spring-boot-devtools`依赖。
 
#### 3. 结合HomeController控制器及其index()的注解，说明为什么在运行项目启动文件后，访问http://127.0.0.1:8080能打开视图resources/templates/home/index.html？
【答】
> 可以，因为直接访问本地，返回的通常是整个项目的index页面
 
#### 4. 为什么删除项目配置文件application.properties不会影响项目运行？
【答】
> 因为本项目不需要用到数据库或缓存。
 
#### 5. 截图UserController控制器注入服务层对象的代码，解释为什么项目没有Spring及Spring MVC的配置文件？
【答】
> 因为`spring-boot-start-web`依赖已经包含了`spring`的配置文件和`springMvc`的配置文件，所以可以省略掉。

 
#### 6. 截图单元测试文件代码，并指出Spring Boot单元测试的方便之处。
【答】
> Springboot框架只需要在测试类添加`@SpringBootTest`；
> Spring框架进行单元测试的时候需要添加@Runwith(目标类)和@ContextConfiguration（配置文件）.
 

 
 
#### 7. 结合视图模板文件showUserList.html代码，指出与JSTL循环标签<c:forEach>对应、需要对HTML标签注入的Thymeleaf属性是什么？
【答】
> th:each属性
 
#### 8. 如何对本项目打包为.jar文件？如何脱离IDEA环境独立运行项目？
【答】
> 1、【项目】à 【Lifecycle】 双击package完成保存
> 2、将target 中SpringBootBasic-0.0.1-SNAPSHOT.jar 复制到任意目录
> 3、运行 java- jar SpringBootBasic-0.0.1-SNAPSHOT.jar
 
 
## 二、分别打开项目JPAAndRedisAndTransaction，掌握使用Spring Data JPA访问数据库的方法
#### 1. 截图项目配置文件代码。
【答】
> 

 
#### 2.分别截图数据访问层接口UserRepository、NewsRepository和JPATest测试类的方法findUserByPrimary()、getAllUser()的代码，写出Spring Data JPA提供的两个通用泛型接口名称并与MyBatis Plus的BaseMapper<T>接口进行异同点比较。
【答】
> 泛型接口：CrudRepository<T,TD>、JpaRepository<T,ID>
> 相同点：spring data jpa本身具有从实体类自动生成数据表的功能，作为接口可以使用这个接口，而mybatis plus没有，因此BaseMapper无法使用这个方式，通常MP需要通过第三方实现。
> 不同点：
UserRepository

NewsRepository

JPATest

 
#### 3. 删除项目配置文件里阿里巴巴数据源的配置代码，会影响单元测试吗？说明其原因。
【答】
> 不影响，删除阿里巴巴的数据源，会自动配置默认的数据源。
 
#### 4. 确认memmana数据库没有包含表account后，运行测试类JPATest的方法autoCreateTableFromEntity()。刷新数据库后，截图自动生成的表account的记录，并说明使用这一功能的前提条件。
【答】
> 前提：需要添加在xml配置文件中添加`spring.jpa.hibernate.ddl-auto=update||create`,表示自动生成数据库表

 
 
 
## 三、分别打开项目MemMana和MemMana2，掌握使用MyBatis Plus框架访问数据库的方法，并与Spring Data JPA对比
#### 1. 截图项目MemMana的配置文件代码。
 【答】

 
#### 2.分别截图项目MemMana启动类和NewsMapper接口的代码，并回答对项目启动类添加注解@MapperScan()的好处？
【答】
> @MapperScam的好处：可以省略各映射接口上的注解@Mapper

 


 
#### 3. 在项目MemMana配置文件里，可以使用其它的数据源吗？
【答】  
> 可以，
 
#### 4. 比较项目MemMana与MemMana2技术架构上的异同点。
【答】  
>  
 
## 【小结】
#### 1.试比较SSM整合开发与Spring Boot开发的关系。说明Spring Boot为什么比SSM有更高的开发效率？
> 不需要手工添加依赖，解决依赖版本冲突问题，不需要过多的配置。Springboot整合了更多的框架，默认配置了很多框架的使用方式，无需重启即可生效，内置Web服务器Tomcat。
 
#### 2.如何使用Spring Boot的热部署功能？
> 添加了spring-boot-devtools 依赖，打开项目的【Edit Configurations】对话框。单击链接【Modify options】，分别选择【On ‘Update’ action】以及【On frame deactivated】并均修改为【Update classes and resources】
 
#### 3.在Spring Boot项目中，@Service注解和@Bean注解的用法有何区别？
> 1. 作用对象不同：@Service注解作用于类，而 @Bean 注解作用于方法
> 2. 作用内容不同：@Service对应服务层，主要设计一些复杂的逻辑；@Bean 注解比 @Service注解的自定义更强，使用@Bean注解来注册 bean。
 
#### 4.在application.yml文件里写项目配置代码，有哪些注意事项？
> 注意缩进，并且还有属性与数据间需要空一格。
 
#### 5.使用Spring Data JPA或MyBatis Plus框架访问数据库，实体类都必须定义主键吗？为什么建议要定义主键？
> 必须定义主键；因为方便关系型数据库、NoSQL数据库和内存数据结构查找内容；

