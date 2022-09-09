AssetsFolder = "assets"

function LoadImage(name)
    return love.graphics.newImage(AssetsFolder .. "/" .. name .. ".png")
end
