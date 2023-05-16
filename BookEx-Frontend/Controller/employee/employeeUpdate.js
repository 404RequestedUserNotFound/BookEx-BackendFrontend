var app = angular.module('my-app', []);
app.controller('employeeUpdateCtrl', function($scope, $http) 
{
  $scope.updateEmployee = function() 
  {
    var data = {
        EmployeeId: $scope.employeeId,
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
    $http.post("https://localhost:44373/api/employee/update", data).then(function(resp) 
    {
      location.reload();

      alert("Employee profile has updated");


    }, function(err) 

    {
      alert("Please fill all the fields");


    });
  };
});
