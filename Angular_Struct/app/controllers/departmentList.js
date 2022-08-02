app.controller("departmentList",function($scope,$http){
    $http.get("https://localhost:44388/api/department").then(
        function(rsp){
            debugger;
            $scope.depts = rsp.data;
        },
        function(err){

        }
    )
});
