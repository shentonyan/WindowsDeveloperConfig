// Hello-world probe for the WinForms flow.
//
// Constructing a WinForms control and reading back its properties forces the
// Windows Forms assemblies and the Windows Desktop runtime to actually load.
// The window is then shown for the person running this manual-only flow; close
// it to finish. If the .NET SDK install was incomplete (e.g. missing Desktop targeting
// pack), the `new Form()` call below would fail at runtime and the harness
// would flag the flow broken.

using System;
using System.Windows.Forms;

using var form = new Form { Text = "hello-winforms" };
Console.WriteLine($"WinForms: {form.Text}");
form.ShowDialog();