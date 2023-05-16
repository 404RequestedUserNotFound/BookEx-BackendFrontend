var app = angular.module('my-app', []);
app.controller('employeeAddCtrl', function($scope, $http) 
{
  $scope.createEmployee = function() 
  {
    var data = {
        FirstName: $scope.firstName,
        LastName: $scope.lastName,
        Username: $scope.username,
        Phone: $scope.phone,
        PresentAddress: $scope.presentAddress,
        PermanentAddress: $scope.permanentAddress,
        NID: $scope.nid,
        Education: $scope.education,
        Email: $scope.email,
        Password: $scope.password,
        ConfirmPassword: $scope.confirmPassword
      };
    $http.post("https://localhost:44373/api/employee/add", data).then(function(resp) 
    {
      location.reload();

      alert("Employee has been registered");

    }, function(err) 

    {
      alert("Please fill all the fields");

    });
  };
});
