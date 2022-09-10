require("type")
local component = require("component")

function SnakeSegmentEntity()
    local obj = GameObject()
    component.pos(obj)
    obj.type = "snake_segment"
end


function SnakeEntity()
    local obj = GameObject()
    obj.type = "snake"
    obj.segements = {}
    obj.update = function ()
        obj.segements
    end
end