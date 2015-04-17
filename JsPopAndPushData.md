#code for rend json data to html element.

# pop data #

```
var popData=function(frm,obj){
	$.each($("#"+frm).find("[id^='txt']"),function(index,ele){
		var prefix=($(this).attr("id").replace("txt_",""));
		try{
			eval("obj."+prefix+"=encodeURIComponent($(this).val())");
		}catch(e){};
		
	});

};
```


## Details ##

this method for submit data from html element to json object;
example:
> var shop={};
> popData("fm\_bindcode",shop);



# push data #
```
var pushData=function(items,prefix){
	$.each(items,function(key,value){
		if(prefix=="txt"||prefix=="sl"||prefix=="ipt"){
			//try{
				$("#"+prefix+"_"+key).val(decodeURIComponent(value));
			//}catch(e){};
		}else
		{
			try{
				$("#"+prefix+"_"+key).html(decodeURIComponent(value));
	
			}catch(e){}
		}
	});
};

```
**push data pulgin vesion**

```
var pushDataPlu=function(items,prefix){
	$.each(items,function(key,value){
		///recursion
		if(items[key].constructor==({}).constructor)
		{
			if(prefix.indexOf("tmpl")<0){ 
				pushDataPlu(items[key],prefix);
			}else
			{
				$("ul#data_"+prefix).append("<li>");
				for(var e in items[key]){
					$("ul#data_"+prefix).append(decodeURIComponent(items[key][e]));
				}
				$("ul#data_"+prefix).append("</li>");
				return;
			}
		};
		if(items[key].constructor==([]).constructor){
			pushDataPlu(items[key],key+"tmpl");
		};
		
		//binding methods
		if(prefix=="txt"||prefix=="sl"||prefix=="ipt"){
			//try{
				$("#"+prefix+"_"+key).val(decodeURIComponent(value));
			//}catch(e){};
		}
		else
		{
			try{
				$("#"+prefix+"_"+key).html(decodeURIComponent(value));
	
			}catch(e){}
		}
	});
};
```


## Detail ##


> var intro=res.data;
> pushData(intro,"txt");
> pushDataPlu(intro,"c");