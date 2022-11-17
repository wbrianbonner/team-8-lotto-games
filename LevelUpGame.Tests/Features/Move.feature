Feature: Move
    I want to move my character. If they attempt to move past a boundary, the move results in no change in position.

@acceptance
Scenario Outline: Move in a direction
    Simple example of how to test move

    Given the character starts at position with XCoordinates <startingPositionX>
    And starts at YCoordinates <startingPositionY>
    And the player chooses to move in <direction>
    When the character moves
    Then the character is now at position with XCoordinates <endingPositionX>
    And YCoordinates  <endingPositionY>
    Examples:

        | startingPositionX | startingPositionY | direction | endingPositionX | endingPositionY |
        | 0 | 0 | up | 0 | 1 |
        | 0 | 0 | down | 0 | 0 |
        | 0 | 0 | left | 0 | 0 |
        | 0 | 0 | right | 1 | 0 |
        | 0 | 9 | up | 0 | 9 |
        | 0 | 9 | down | 0 | 8 |
        | 0 | 9 | left | 0 | 9 |
        | 0 | 9 | right | 1 | 9 |
        | 9 | 0 | up | 9 | 1 |
        | 9 | 0 | down | 9 | 0 |
        | 9 | 0 | left | 8 | 0 |
        | 9 | 0 | right | 9 | 0 |
        | 9 | 9 | up | 9 | 9 |
        | 9 | 9 | down | 9 | 8 |
        | 9 | 9 | left | 8 | 9 |
        | 9 | 9 | right | 9 | 9 |
