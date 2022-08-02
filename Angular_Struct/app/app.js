var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider","$httpProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/demopage.html"
    })
    .when("/demo", {
        templateUrl : "views/pages/demopage.html",
        controller: 'demo'
    })
    .when("/demo2", {
        templateUrl : "views/pages/demo2.html",
          controller: 'demo2'
    })
    .when("/products", {
        templateUrl : "views/pages/products.html",
        controller: 'products'
    })
    .when("/departments", {
        templateUrl : "views/pages/departments.html",
        controller: 'departments'
    })
    .when("/students", {
        templateUrl : "views/pages/students.html",
        controller: 'students'
    })
    .when("/summ2", {
        templateUrl : "views/pages/summ22.html",
        controller:"summ2"
    })
    .when("/dList", {
        templateUrl : "views/pages/departmentList.html",
        controller:"departmentList"
    })
    .when("/cDept", {
        templateUrl : "views/pages/createDept.html",
        controller:"createDept"
    })
    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
app.factory("interCeptor",function($q,$location){
    return{
        'request':function(config){
            config.headers.Authorization="token";
            console.log("intercepted");
            return config;
        },
        'reponse':function(rejection){
        }
    }
});
app.config(function($httpProvider){
	$httpProvider.interceptors.push("interCeptor");
});