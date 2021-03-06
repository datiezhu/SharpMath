﻿// Canvas2DTest.cs, 07.11.2019
// Copyright (C) Dominic Beger 07.11.2019

using System;
using System.Windows.Forms;
using SharpMath.Geometry;
using SharpMath.Presentation;

namespace SharpMath.Canvas2DTest
{
    public partial class Canvas2DTest : Form
    {
        public Canvas2DTest()
        {
            InitializeComponent();
        }

        private void Canvas2DTest_Load(object sender, EventArgs e)
        {
            testCanvas.Functions.Add(new FunctionWrapper(x => Math.Pow(x, 3)));
            testCanvas.Functions.Add(new FunctionWrapper(x => 1.5 * Math.Sin(x)));
            testCanvas.Vectors.Add(new Vector2(4, 8));
        }
    }
}