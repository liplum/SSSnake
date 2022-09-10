require("utils")
AllContents = {}

Content = {
    name = "",
    load = function() end,
    init = function() end,
}

function Content:new(name)
    local o = {}
    setmetatable(o, self)
    o.__index = self
    o.name = name or self.name
    AllContents[name] = o
    return o
end

function SnakeType(name)
    local t = Content(name)
    t.load = function()
        t.headImg = LoadImage(t.name .. "-head")
        t.bodyImg = LoadImage(t.name .. "-body")
        t.tailImg = LoadImage(t.name .. "-tail")
    end
end
