require("all")
require("loader")

love.window.setTitle("SSSnake")
-- hardcode size
TileSize = 32
TileRow = 50
TileColumn = 50
WindowWidth = 800
WindowHeight = 600
love.window.setMode(WindowWidth, WindowHeight)
PrintAPI(love, "love")

function love.load()
    LoadContents(AllContents)
end

function love.draw()
    love.graphics.print("Hello World", WindowWidth / 2, WindowHeight / 2)
end
