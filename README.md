# Windows Power

A Windows Forms utility that schedules a **power state change** for the local machine after a user-defined countdown.



https://github.com/user-attachments/assets/fbbde765-49fa-425d-b587-f067674afdb1


---

## 1. Project Summary

`Windows Power` is a desktop app targeting **.NET Framework 4.8.1**.  
It allows users to:

- Choose a power action:
  - `ShutDown`
  - `Reboot`
  - `Sleep`
- Set a countdown timer (`HH:MM:SS`)
- Start the countdown
- Stop/reset before execution
- Receive a warning notification 30 seconds before action execution

The app is implemented with two forms:

- `frmMain` → main workflow and countdown engine
- `frmTimer` → timer input/edit UI

---

## 2. Technology and Runtime

- **Framework:** `.NET Framework v4.8.1`
- **UI:** `System.Windows.Forms`
- **Power action execution:**  
  - `shutdown /s /t 0`
  - `shutdown /r /t 0`
  - `Application.SetSuspendState(...)`
- **Application type:** WinExe (`Program.cs` launches `frmMain`)

---

## 3. Project Structure

- `Program.cs`  
  App entry point (`Application.Run(new frmMain())`).

- `frmMain.cs` / `frmMain.Designer.cs`  
  Main form logic and controls:
  - Power state selection (`ComboBox`)
  - Set timer action
  - Countdown display
  - Stop button
  - Pre-action notification via `NotifyIcon`

- `TimerForm.cs` / `TimerForm.Designer.cs`  
  Timer setup form:
  - Numeric inputs for hour/minute/second
  - Live labels
  - OK + Reset actions
  - Shared timer state (`stTime TheTimeOfTimer`)

- `PowerCore.cs`  
  Static methods that execute the final power operation.

- `App.config`  
  Declares supported runtime (`v4.8.1`).

---

## 4. Feature Deep Dive

## 4.1 Power State Selection

In `frmMain`:

- `comboBox1` contains `ShutDown`, `Reboot`, `Sleep`.
- On selection change:
  1. Selected text is mapped to `enPowerState`.
  2. Countdown labels and `Set Timer` button are enabled.

This keeps the UI locked until a valid action is selected.

---

## 4.2 Timer Setup (`frmTimer`)

`frmTimer` stores selected time in:

- `stTime.Hour`
- `stTime.Min`
- `stTime.Sec`

Input constraints:

- Hour: `0..23`
- Min: `0..59`
- Sec: `0..59`

Each `NumericUpDown` has a `Tag` (`Hour`, `Min`, `Sec`) and uses one handler (`UpDown_ValueChanged`) to route updates through `SetTimer(...)`.

`btnOk`:

- Calls `Start()`
- Hides timer form (returns control to `frmMain`)

`btnRest`:

- Sets `ChangePowerState = false`
- Clears counters and labels through `RestTimer()`
- Prevents final power action when timer reaches zero after reset scenario

---

## 4.3 Countdown Engine (Main Form)

Actual countdown logic runs in `frmMain.timer1_Tick` (1-second interval).

Flow highlights:

1. **30-second warning trigger**
   - When time equals `00:00:30`, app shows warning balloon notification.

2. **Zero-time completion**
   - Stops timer
   - Re-enables timer form inputs
   - Resets timer labels on both forms
   - Hides stop button, re-enables `Set Timer`
   - Executes selected power action only if `ChangePowerState == true`

3. **Time decrement logic**
   - Handles hour rollover (`HH:00:00` → `(HH-1):59:59`)
   - Handles standard second decrement and minute borrow
   - Keeps both forms synchronized visually

---

## 4.4 Notification and User Safety

A `NotifyIcon` warning appears at 30 seconds remaining.

- Title references selected action (e.g., “Your Device Will Reboot Soon”)
- Clicking the balloon calls the same stop logic as `Stop` button
- This gives a final cancellation path before action execution

---

## 4.5 Power Execution Layer (`PowerCore`)

`PowerCore` methods are static and action-specific:

- `ShutDown()` → `Process.Start("shutdown", "/s /t 0")`
- `Reboot()` → `Process.Start("shutdown", "/r /t 0")`
- `Sleep()` → `Application.SetSuspendState(PowerState.Suspend, force: true, disableWakeEvent: true)`

`frmMain.DoPowerChange()` dispatches based on selected `enPowerState`.

---

## 5. End-to-End User Workflow

1. Launch app
2. Select power action from dropdown
3. Click `Set Timer`
4. In timer dialog, set `Hour/Min/Sec`
5. Click `OK`
6. Main countdown starts
7. Optional:
   - Click `Stop` any time
   - Click notification balloon at 30 seconds to cancel
8. If timer completes and not canceled, selected power action is executed

---

