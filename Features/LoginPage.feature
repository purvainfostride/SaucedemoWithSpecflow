Feature: Checking Login Functionality of Application


Scenario Outline: To check whether the user is able to login with Valid Credentials
    Given User is on Login Page
    When User enter "<username>" and "<password>"
    And User click on login button
    Then User is on Inventory page
    Examples:
      | username                | password     |
      | standard_user           | secret_sauce |
      | problem_user            | secret_sauce |
      | performance_glitch_user | secret_sauce |


