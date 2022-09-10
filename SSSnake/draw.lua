DrawScale = 1
DrawScaleX = 1
DrawScaleY = 1


function Draw(drawable, x, y, angle)
    love.graphics.draw(drawable, x, y, angle / 180 * math.pi, DrawScale * DrawScaleX, DrawScale * DrawScaleY)
end
