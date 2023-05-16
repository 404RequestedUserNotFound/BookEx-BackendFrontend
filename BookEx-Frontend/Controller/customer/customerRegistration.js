var app = angular.module('my-app', []);
app.controller('customerAddCtrl', function($scope, $http) 
{
  $scope.createCustomer = function() 
  {
    var data = {
        FirstName: $scope.firstName,
        LastName: $scope.lastName,
        Username: $scope.username,
        Email: $scope.email,
        Password: $scope.password,
        ConfirmPassword: $scope.confirmPassword
      };
    $http.post("https://localhost:44373/api/customer/add", data).then(function(resp) 
    {
      location.reload();

      alert("Customer profile has created");

    }, function(err) 

    {
      alert("Please fill all the fields");

    });
  };
});
