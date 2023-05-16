var app = angular.module('my-app', []);
app.controller('customerUpdateCtrl', function($scope, $http) 
{
  $scope.updateCustomer = function() 
  {
    var data = {
        CustomerId: $scope.adminId,
        FirstName: $scope.firstName,
        LastName: $scope.lastName,
        Username: $scope.username,
        Email: $scope.email,
        Password: $scope.password,
        ConfirmPassword: $scope.confirmPassword
      };
    $http.post("https://localhost:44373/api/customer/update", data).then(function(resp) 
    {
      location.reload();

      alert("Customer profile has updated");


    }, function(err) 

    {
      alert("Please fill all the fields");


    });
  };
});
