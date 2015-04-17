#this demo for write a static class in javascript.

# Static Class In Js #

```html

<head>
<script type="text/javascript" >

var compute={};
compute.add=function(a,b){

document.write(a+b);
};
compute.muti=function(a,b){
document.write(a*b);
};
compute.getlist=function(str){
document.write("<div>");
for(var x in str){
document.write("<li>"+str[x]+"

Unknown end tag for &lt;/li&gt;

");
};
document.write("

Unknown end tag for &lt;/div&gt;

");
}




Unknown end tag for &lt;/script&gt;





Unknown end tag for &lt;/head&gt;



<body>

<script type="text/javascript">
// var x=new compute();
compute.add(10,12);

compute.getlist("呵呵，如何，这样就只会创建一次方法而方法又在类里面了，视觉上也要好看点，这样会更易于js方法的组建与管理");


Unknown end tag for &lt;/script&gt;





Unknown end tag for &lt;/body&gt;


```
}}}```