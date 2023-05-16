var app = angular.module('my-app', []);
app.controller('adminAddCtrl', function($scope, $http) 
{
  $scope.createAdmin = function() 
  {
    var data = {
        FirstName: $scope.firstName,
        LastName: $scope.lastName,
        Username: $scope.username,
        Phone: $scope.phone,
        PresentAddress: $scope.presentAddress,
        PermanentAddress: $scope.permanentAddress,
        NID: $scope.nid,
        Email: $scope.email,
        Password: $scope.password,
        ConfirmPassword: $scope.confirmPassword
      };
    $http.post("https://localhost:44373/api/admin/add", data).then(function(resp) 
    {
      location.reload();

      alert("Admin registration has completed!");

    }, function(err) 

    {
      alert("Please fill all the fields to complete the registration");

    });
  };
});
