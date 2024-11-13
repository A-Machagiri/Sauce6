Feature: Login Functionality
  As a user of Swag Labs
  I want to log in using valid credentials
  So that I can access the application

  Scenario: Successful Login
    Given the user is on the login page
    When the user enters valid credentials
    Then the user is redirected to the products page

  Scenario: Invalid Login
    Given the user is on the login page
    When the user enters invalid credentials
    Then an error message is displayed

  Scenario: Locked-Out User
    Given the user is on the login page
    When the user tries to login as a locked-out user
    Then the user should see a lockout message