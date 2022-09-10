function GameObject()
    local obj = {
        update = function() end,
    }
    return obj
end

--[[
    components:
    - pos
    - controller
]]

--[[
    pos componet:
    coordinate
    direction
]]
local function posComponet(obj)
    obj.pos = {
        x = 0,
        y = 0,
        dir = 0 -- positive x asix as default
    }
end

local function velComponet(obj)
    obj.vel = {
        
    }
end

return {
    pos = posComponet
}