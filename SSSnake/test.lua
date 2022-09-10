local TestClass = {
    foo = "foo",
    bar = 1
}

function TestClass:new(foo, bar)
    local o = {}
    setmetatable(o, self)
    o.__index = self
    o.foo = foo or TestClass.foo
    o.bar = bar or TestClass.bar
    return o
end

local t = TestClass:new("aaaaaaa", -10)

local SubClass = TestClass:new()

function SubClass:new()
    local o = {}
    setmetatable(o, self)
    o.__index = self
    return o
end

print(SubClass)

local s = SubClass:new()
s:test()
