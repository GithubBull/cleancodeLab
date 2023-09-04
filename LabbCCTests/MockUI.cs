﻿using System.Diagnostics;
using LabbCC;

namespace LabbCCTests;

public class MockUI : IUI
{
    private int _outputCounter;
    public MockUI()
    {
        _outputCounter = 0;
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public void ExitGame()
    {
        throw new NotImplementedException();
    }

    public string Input()
    {
        _outputCounter++;
        switch (_outputCounter)
        {
            case 1:
                return "1";
            case 2:
                return "HEJ";
            default:
                return "";
        }

    }

    public void Output(string s)
    {
        Debug.WriteLine($"'MockUI outputs: {s}");
    }
}
