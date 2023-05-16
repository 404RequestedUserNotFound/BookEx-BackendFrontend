var app = angular.module('my-app', []);
app.controller('employeeAllCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/employee").then(function(resp){
        $scope.employees = resp.data;
    },function(err){
        console.log(err);
    });
  });


  app.controller('employeeDeleteCtrl', function ($scope, $http) {
    $scope.deleteEmployee = function (id) {
        var confirmDelete = confirm("Are you sure you want to delete this employee?");
        if (confirmDelete) {
            $http.get("https://localhost:44373/api/employee/delete/" + id).then(function(resp){
                
            alert("Failed to delete employee!");
            }, function (err) {
                location.reload();

                alert("Employee deleted successfully!");
                console.log(err);
            });
        }
    };
});