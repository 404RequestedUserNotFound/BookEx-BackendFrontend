var app = angular.module('my-app', []);
app.controller('customerAllCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/customer").then(function(resp){
        $scope.customers = resp.data;
    },function(err){
        console.log(err);
    });
  });


  app.controller('customerDeleteCtrl', function ($scope, $http) {
    $scope.deleteCustomer = function (id) {
        var confirmDelete = confirm("Do you want to delete this customer?");
        if (confirmDelete) {
            $http.get("https://localhost:44373/api/customer/delete/" + id).then(function(resp){
                
            alert("Failed to delete customer!");
            }, function (err) {
                location.reload();

                alert("customer deleted successfully!");
                console.log(err);
            });
        }
    };
});