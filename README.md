# John-Lemons-Haunted-Jaunt

I added an exit waypoint that only appears on screen if the player is moving away from the exit. To do this I took the dot product of player position and exit position and only rendered the waypoint image if the result is less than 0.

I used linear interpolation to change the size of the exit waypoint image depending on how close the ploayer is to the exit. The further away the player is, the larger the waypoint will be.

For the particle system, I added purple orbs emminating from the ghosts. The particle system is part of the ghost prefab so each ghost instance has its own particles and they follow the ghosts around.

I worked on this project solo. I did discuss it a bit with Jesse B but we didnt work on it together.