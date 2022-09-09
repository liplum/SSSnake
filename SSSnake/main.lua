require("all")
require("loader")

love.window.setTitle("SSSnake")

function love.load()
    LoadContents(AllContents)
end

function love.draw()
    love.graphics.print("Hello World", 400, 300)
end