app.controller("createDept",function($scope,$http){
    $scope.test=function(){
        var data={Name:$scope.name,Id:$scope.id};
        $http.post("https://localhost:44388/api/department/create",data).then(function(rsp){
            alert(rsp.data);
        },function(err){});
    };
    
});
